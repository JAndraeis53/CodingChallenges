import React, { useState, createContext } from "react";

export const taskContext = createContext();

export const taskProvider = (props) => {
  const [tasks, settasks] = useState([]);

  const gettasks = () => {
    return fetch("http://localhost:8088/tasks?_expand=location")
      .then((res) => res.json())
      .then(settasks);
  };

  const addtask = (taskObj) => {
    return fetch("http://localhost:8088/tasks", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(taskObj),
    }).then(gettasks);
  };

  return (
    <taskContext.Provider
      value={{
        tasks,
        gettasks,
        addtask,
      }}
    >
      {props.children}
    </taskContext.Provider>
  );
};
