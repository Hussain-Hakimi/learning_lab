from flask import Flask, request, send_file
from flask_cors import CORS
import json
from graph_generator import GraphGenerator
import os

app = Flask(__name__)
CORS(app)

# Initialize graph generator
graph_gen = GraphGenerator()

@app.route('/', methods=['GET'])
def home():
    return {'message': 'Interactive Data Visualization System API'}, 200

@app.route('/generate-graph', methods=['POST'])
def generate_graph():
    try:
        data = request.json
        
        # Extract data from request
        names = data.get('names', [])
        marks = data.get('marks', [])
        graph_type = data.get('graph_type', 'bar')
        color = data.get('color', '#3498db')
        size = data.get('size', 'medium')
        
        # Validate data
        if not names or not marks or len(names) != len(marks):
            return {'error': 'Invalid data'}, 400
        
        # Generate graph
        image_path = graph_gen.generate(
            names=names,
            marks=marks,
            graph_type=graph_type,
            color=color,
            size=size
        )
        
        # Send image
        return send_file(image_path, mimetype='image/png')
        
    except Exception as e:
        print(f"Error: {str(e)}")
        return {'error': str(e)}, 500

if __name__ == '__main__':
    # Create output directory if it doesn't exist
    if not os.path.exists('output'):
        os.makedirs('output')
    
    app.run(debug=True, host='localhost', port=5000)