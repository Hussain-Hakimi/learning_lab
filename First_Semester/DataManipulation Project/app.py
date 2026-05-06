import os
from flask import Flask, request, send_file, send_from_directory
from flask_cors import CORS
from graph_generator import GraphGenerator

app = Flask(__name__, static_folder='static', static_url_path='')
CORS(app)

# Initialize graph generator
graph_gen = GraphGenerator()


@app.route('/')
def home():
    # Serve the main HTML page - FIXED: removed duplicate 'static/'
    return send_from_directory('static', 'index.html')


@app.route('/styles.css')
def serve_css():
    # FIXED: removed duplicate 'static/'
    return send_from_directory('static', 'styles.css')


@app.route('/script.js')
def serve_js():
    # FIXED: removed duplicate 'static/'
    return send_from_directory('static', 'script.js')


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

    # Create static directory if it doesn't exist
    if not os.path.exists('static'):
        os.makedirs('static')

    app.run(debug=True, host='localhost', port=5000)
