import React from "react"
import { Route } from "react-router-dom"
import { Taskboard } from "./Taskboard"
import { taskCard } from "./task/taskCard.js"

export const ApplicationViews = () => {
    return (
        <>
            <Route exact path="/">
                <Taskboard />
            </Route>

            <Route path="/tasks">
                <taskCard />
            </Route>
        </>
    )
}