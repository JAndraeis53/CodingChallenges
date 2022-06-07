This is my repository for a Technical Assessment. Below are React instructions for operating an app.

## To Run App 
Run this script to run web application
<< npm start >>

Run this script to surface local database
<<json-server -p 8088 -w database.json>>

## Guidelines

Feature
Task manager for authenticated users. 

Requirements
1.	Back End: NodeJS (prefer framework like Nest.js, Express, Koa, Hapi)
2.	Front End: Vue.js or React
Implementation Details

Create a Task service to allow users to perform operations on their tasks. The user can,
1.	Create a task (name, description, and due date)
a.	A task will have two statuses: “New” and “Completed”
b.	“New” is a default status
2.	See all Tasks (both new & completed)
3.	View details of a single task in a details view
4.	Update a task name, description, due date, and status (“New” to “Completed”)
5.	Delete a task

Create an app that implements the mocks below and uses the task service you created.  Consider the mocks a suggestion and feel free to implement as you see fit.
Suggestions:
1.	Limit yourself to about 4 hours with time spread fairly evenly between implementation details.   It is not expected to be fully functional in this amount of time, just something that shows how you would proceed if you had more time.
2.	Our goal in this development challenge is to see your thought process; there are no right or wrong answers, we just want to see how you reason about various engineering decisions.  
3.	We’ve purposely left things loosely defined & designed so you can use your discretion and make some opinionated / personal choices.
4.	Don’t attempt to get everything perfect.  We are more interested in reading what you consider necessary to make this piece of work “production ready”.  Consider writing it in readme.
5.	Have fun! Don’t take it too seriously, we just want to learn about you and your style.

