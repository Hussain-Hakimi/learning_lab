// Data storage
let studentsData = [];

// DOM Elements
const studentNameInput = document.getElementById('studentName');
const studentMarksInput = document.getElementById('studentMarks');
const addStudentBtn = document.getElementById('addStudentBtn');
const generateGraphBtn = document.getElementById('generateGraphBtn');
const clearDataBtn = document.getElementById('clearDataBtn');
const tableBody = document.getElementById('tableBody');
const graphContainer = document.getElementById('graphContainer');
const graphTypeSelect = document.getElementById('graphType');
const graphColorInput = document.getElementById('graphColor');
const graphSizeSelect = document.getElementById('graphSize');

// Event Listeners
addStudentBtn.addEventListener('click', addStudent);
generateGraphBtn.addEventListener('click', generateGraph);
clearDataBtn.addEventListener('click', clearAllData);
studentNameInput.addEventListener('keypress', (e) => {
    if (e.key === 'Enter') addStudent();
});
studentMarksInput.addEventListener('keypress', (e) => {
    if (e.key === 'Enter') addStudent();
});

// Add Student Function
function addStudent() {
    const name = studentNameInput.value.trim();
    const marks = parseFloat(studentMarksInput.value);

    // Validation
    if (!name) {
        alert('Please enter a student name');
        return;
    }

    if (isNaN(marks) || marks < 0 || marks > 100) {
        alert('Please enter valid marks (0-100)');
        return;
    }

    // Add to data
    studentsData.push({ name, marks });

    // Clear inputs
    studentNameInput.value = '';
    studentMarksInput.value = '';
    studentNameInput.focus();

    // Update display
    updateStudentsTable();
}

// Update Students Table
function updateStudentsTable() {
    tableBody.innerHTML = '';

    studentsData.forEach((student, index) => {
        const row = document.createElement('tr');
        row.innerHTML = `
            <td>${student.name}</td>
            <td>${student.marks}</td>
            <td>
                <button class="btn-delete" onclick="deleteStudent(${index})">Delete</button>
            </td>
        `;
        tableBody.appendChild(row);
    });
}

// Delete Student Function
function deleteStudent(index) {
    studentsData.splice(index, 1);
    updateStudentsTable();
}

// Generate Graph Function
function generateGraph() {
    if (studentsData.length === 0) {
        alert('Please add at least one student');
        return;
    }

    const graphType = graphTypeSelect.value;
    const color = graphColorInput.value;
    const size = graphSizeSelect.value;

    // Show loading state
    graphContainer.innerHTML = '<div class="loading"></div>';

    // Prepare data
    const names = studentsData.map(s => s.name);
    const marks = studentsData.map(s => s.marks);

    // Send to backend
    fetch('http://localhost:5000/generate-graph', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({
            names: names,
            marks: marks,
            graph_type: graphType,
            color: color,
            size: size
        })
    })
    .then(response => {
        if (!response.ok) {
            throw new Error('Failed to generate graph');
        }
        return response.blob();
    })
    .then(blob => {
        const url = URL.createObjectURL(blob);
        const img = document.createElement('img');
        img.src = url;
        graphContainer.innerHTML = '';
        graphContainer.appendChild(img);
    })
    .catch(error => {
        console.error('Error:', error);
        graphContainer.innerHTML = `<p style="color: red;">Error generating graph: ${error.message}</p>`;
    });
}

// Clear All Data Function
function clearAllData() {
    if (confirm('Are you sure you want to clear all data?')) {
        studentsData = [];
        updateStudentsTable();
        graphContainer.innerHTML = '<p class="placeholder">Your graph will appear here...</p>';
    }
}

// Initialize on page load
document.addEventListener('DOMContentLoaded', () => {
    studentNameInput.focus();
});