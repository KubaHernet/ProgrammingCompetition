import { useEffect, useState } from "react"
import { Button, Col, Form, Row } from "react-bootstrap"
import { Task } from "./types"

const getTasksUrl = `${process.env.REACT_APP_API_URL}/tasks`
const postSubmissionUrl = `${process.env.REACT_APP_API_URL}/submissions`

export const SolveTask = () => {
const [tasks, updateTasks] = useState<Task[]>([]),
    [selectedTask, updateSelectedTask] = useState<Task|undefined>(),
    [userName, updateUserName] = useState<string>(""),
    [solution, updateSolution] = useState<string>("");

useEffect(() => {
    const fetchTasks = async () => {
        console.log(getTasksUrl)
        const response = await fetch(getTasksUrl)
        const responseJson = await response.json()
        updateTasks(responseJson as Task[])
    }
        fetchTasks()
}, [])

const onSubmit = async () => {
    const response = await fetch(postSubmissionUrl, {
        method: 'POST',
        mode: 'cors',
        credentials: 'omit',
        referrerPolicy: 'no-referrer',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({
            taskId: selectedTask?.id,
            userName,
            language: "csharp",
            solution
        })
    });

    if(response.ok)
    {
        var { success } = await response.json();
        alert(success ? "correct!" : "please try again")
    }
}

return <Col md={4}>
    <Form>
        <Form.Group as={Row}>
            <Form.Label column="sm" md={4}>
                NAME
            </Form.Label>
            <Col>
                <Form.Control value={userName} onChange={e => updateUserName(e.target.value) } size="sm" type="text" />
            </Col>
        </Form.Group>
        <Form.Group as={Row}>
            <Form.Label column="sm" md={4}>
                SELECT TASK
            </Form.Label>
            <Col>
                <Form.Control as="select" defaultValue={undefined}
                    onChange={(e) => {
                        console.log(e.target.value)
                        updateSelectedTask(tasks.find(x => x.id === e.target.value))}}>
                            <option value={undefined}>Select task</option>
                    {tasks.map(t => <option key={t.id} value={t.id}>{t.name}</option>)}
                </Form.Control>
            </Col>
        </Form.Group>
        <Form.Group as={Row}>
            <Form.Label column="sm" md={4}>
                DESCRIPTION
            </Form.Label>
            <Col>
                <Form.Control size="sm" plaintext readOnly value={selectedTask?.description || ""} />
            </Col>
        </Form.Group>
        <Form.Group as={Row}>
            <Form.Label column="sm" md={4}>
                SOLUTION CODE
            </Form.Label>
            <Col>
                <Form.Control size="sm" as="textarea" rows={3} value={solution} 
                    onChange={e => updateSolution(e.target.value)} />
            </Col>
        </Form.Group>
        <Form.Group as={Row}>
            <Col md={4} />
            <Col>
                <Button onClick={onSubmit}>Submit</Button>
            </Col>
        </Form.Group>
    </Form>
</Col>
}