import os
import matplotlib

matplotlib.use('Agg')  # Use non-interactive backend
import matplotlib.pyplot as plt
from datetime import datetime


def get_size(size_str):
    """Get figure size based on size string"""
    sizes = {
        'small': (6, 4),
        'medium': (10, 6),
        'large': (12, 8)
    }
    return sizes.get(size_str, (10, 6))


def _generate_bar_chart(names, marks, color):
    """Generate bar chart"""
    plt.bar(names, marks, color=color, alpha=0.7, edgecolor='black', linewidth=1.5)
    plt.xlabel('Students', fontsize=12, fontweight='bold')
    plt.ylabel('Marks', fontsize=12, fontweight='bold')
    plt.title('Student Marks - Bar Chart', fontsize=14, fontweight='bold')
    plt.ylim(0, 105)
    plt.grid(axis='y', alpha=0.3, linestyle='--')
    for i, (name, mark) in enumerate(zip(names, marks)):
        plt.text(i, mark + 2, str(mark), ha='center', va='bottom', fontweight='bold')


def _generate_scatter_plot(names, marks, color):
    """Generate scatter plot"""
    x_pos = range(len(names))
    plt.scatter(x_pos, marks, s=300, color=color, alpha=0.6,
                edgecolor='black', linewidth=2)
    plt.xlabel('Students', fontsize=12, fontweight='bold')
    plt.ylabel('Marks', fontsize=12, fontweight='bold')
    plt.title('Student Performance - Scatter Plot', fontsize=14, fontweight='bold')
    plt.xticks(x_pos, names)
    plt.ylim(0, 105)
    plt.grid(True, alpha=0.3, linestyle='--')
    for i, (x, mark) in enumerate(zip(x_pos, marks)):
        plt.text(x, mark + 2, str(mark), ha='center', va='bottom', fontweight='bold')


def _generate_pie_chart(names, marks):
    """Generate pie chart"""
    from matplotlib import cm
    colormap = cm.Set3
    colors = [colormap(i / len(marks)) for i in range(len(marks))]
    plt.pie(marks, labels=names, autopct='%1.1f%%', startangle=90,
            colors=colors, textprops={'fontsize': 10, 'fontweight': 'bold'})
    plt.title('Percentage Distribution - Pie Chart', fontsize=14, fontweight='bold')
    plt.axis('equal')


class GraphGenerator:
    def __init__(self):
        self.output_dir = 'output'

    def generate(self, names, marks, graph_type, color, size):
        """Generate graph based on parameters"""
        try:
            fig_size = get_size(size)
            plt.figure(figsize=fig_size, facecolor='white')

            if graph_type == 'bar':
                _generate_bar_chart(names, marks, color)
            elif graph_type == 'line':
                self._generate_line_chart(names, marks, color)
            elif graph_type == 'pie':
                _generate_pie_chart(names, marks)  # Now calling the fixed function
            elif graph_type == 'scatter':
                _generate_scatter_plot(names, marks, color)
            else:
                _generate_bar_chart(names, marks, color)

            timestamp = datetime.now().strftime('%Y%m%d_%H%M%S')
            filename = f'graph_{timestamp}.png'
            filepath = os.path.join(self.output_dir, filename)
            plt.tight_layout()
            plt.savefig(filepath, dpi=100, bbox_inches='tight')
            plt.close()
            return filepath
        except Exception as e:
            raise Exception(f"Error generating graph: {str(e)}")

    @staticmethod
    def _generate_line_chart(names, marks, color):
        """Generate line chart"""
        plt.plot(names, marks, marker='o', color=color, linewidth=2.5,
                 markersize=8, label='Marks', markeredgecolor='black', markeredgewidth=1.5)
        plt.xlabel('Students', fontsize=12, fontweight='bold')
        plt.ylabel('Marks', fontsize=12, fontweight='bold')
        plt.title('Student Performance - Line Chart', fontsize=14, fontweight='bold')
        plt.ylim(0, 105)
        plt.legend(loc='best')
        plt.grid(True, alpha=0.3, linestyle='--')
        for i, (name, mark) in enumerate(zip(names, marks)):
            plt.text(i, mark + 2, str(mark), ha='center', va='bottom', fontweight='bold')
