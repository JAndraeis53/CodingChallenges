import React from "react";
import { NavBar } from "./nav/NavBar";
import { ApplicationViews } from "./ApplicationViews";
import "./Taskboard.css";

export const Taskboard = () => (
  <>
    <NavBar />
    <ApplicationViews />
  </>

  // <>
  //     <h2>Task Manager</h2>
  //     <small>Loving care when you're not there.</small>

  //     <address>
  //         <div>Daily Duties</div>
  //         <div>Chores and More</div>
  //     </address>

  //     <h2>Task</h2>
  //     <article className="tasks">
  //         <taskCard />
  //         <taskCard />
  //         <taskCard />
  //     </article>
  // </>
);
