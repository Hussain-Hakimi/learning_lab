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
const downloadBtn = document.getElementById('downloadBtn');

// Helper: escape HTML
function escapeHtml(str) {
    return str.replace(/[&<>]/g, function(m) {
        if (m === '&') return '&amp;';
        if (m === '<') return '&lt;';
        if (m === '>') return '&gt;';
        return m;
    });
}

// Update table display
function updateStudentsTable() {
    tableBody.innerHTML = '';
    if (studentsData.length === 0) {
        tableBody.innerHTML = '<tr><td colspan="3" style="text-align:center;">No students added</td></tr>';
        return;
    }
    studentsData.forEach((student, index) => {
        const row = document.createElement('tr');
        row.innerHTML = `
            <td>${escapeHtml(student.name)}</td>
            <td>${student.marks}</td>
            <td>
                <button class="btn-delete" data-index="${index}">Delete</button>
            </td>
        `;
        tableBody.appendChild(row);
    });
    // attach delete events
    document.querySelectorAll('.btn-delete').forEach(btn => {
        btn.addEventListener('click', (e) => {
            const idx = parseInt(btn.dataset.index);
            studentsData.splice(idx, 1);
            updateStudentsTable();
        });
    });
}

// Add student
function addStudent() {
    const name = studentNameInput.value.trim();
    const marks = parseFloat(studentMarksInput.value);
    if (!name) {
        alert('Please enter a student name');
        return;
    }
    if (isNaN(marks) || marks < 0 || marks > 100) {
        alert('Please enter valid marks (0-100)');
        return;
    }
    studentsData.push({ name, marks });
    studentNameInput.value = '';
    studentMarksInput.value = '';
    studentNameInput.focus();
    updateStudentsTable();
}

// Generate graph via Flask backend
function generateGraph() {
    if (studentsData.length === 0) {
        alert('Please add at least one student');
        return;
    }
    const graphType = graphTypeSelect.value;
    const color = graphColorInput.value;
    const size = graphSizeSelect.value;

    // Show loading
    graphContainer.innerHTML = '<div class="loading"></div>';

    const names = studentsData.map(s => s.name);
    const marks = studentsData.map(s => s.marks);

    fetch('http://localhost:5000/generate-graph', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ names, marks, graph_type: graphType, color, size })
    })
    .then(response => {
        if (!response.ok) {
            return response.json().then(err => { throw new Error(err.error || 'Graph generation failed'); });
        }
        return response.blob();
    })
    .then(blob => {
        const url = URL.createObjectURL(blob);
        const img = document.createElement('img');
        img.src = url;
        graphContainer.innerHTML = '';
        graphContainer.appendChild(img);
        // Store blob for download
        window.currentGraphBlob = blob;
        img.onload = () => URL.revokeObjectURL(url);
    })
    .catch(error => {
        console.error(error);
        graphContainer.innerHTML = `<p style="color: red; text-align: center;">Error: ${error.message}</p>`;
        window.currentGraphBlob = null;
    });
}

// Download graph as PNG
function downloadGraph() {
    if (!window.currentGraphBlob) {
        alert('No graph to download. Please generate a graph first.');
        return;
    }
    const url = URL.createObjectURL(window.currentGraphBlob);
    const a = document.createElement('a');
    a.href = url;
    a.download = `graph_${new Date().toISOString().slice(0,19).replace(/:/g, '-')}.png`;
    document.body.appendChild(a);
    a.click();
    document.body.removeChild(a);
    URL.revokeObjectURL(url);
}

// Clear all data
function clearAllData() {
    if (confirm('Are you sure you want to clear all student data?')) {
        studentsData = [];
        updateStudentsTable();
        graphContainer.innerHTML = '<p class="placeholder">Your graph will appear here...</p>';
        window.currentGraphBlob = null;
    }
}

// Event listeners
addStudentBtn.addEventListener('click', addStudent);
generateGraphBtn.addEventListener('click', generateGraph);
clearDataBtn.addEventListener('click', clearAllData);
if (downloadBtn) downloadBtn.addEventListener('click', downloadGraph);

// Allow Enter key in inputs
studentNameInput.addEventListener('keypress', (e) => { if (e.key === 'Enter') addStudent(); });
studentMarksInput.addEventListener('keypress', (e) => { if (e.key === 'Enter') addStudent(); });

// Initialise with some sample data (optional)
studentsData = [
    { name: "Yahya", marks: 80 },
    { name: "Ali", marks: 90 },
    { name: "AiSaf", marks: 75 },
    { name: "Zara", marks: 95 }
];
updateStudentsTable();