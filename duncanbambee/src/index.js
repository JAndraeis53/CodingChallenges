import React from "react"
import ReactDOM from "react-dom"
import { BrowserRouter as Router } from "react-router-dom"
import { Taskboard } from "./components/Taskboard.js"
import "./index.css"

ReactDOM.render(
    <React.StrictMode>
        <Router>
            <Taskboard />
        </Router>
    </React.StrictMode>,
    document.getElementById("root")
)