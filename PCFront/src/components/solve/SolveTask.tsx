import { Col, Form, Row } from "react-bootstrap"

export const SolveTask = () => 
<Col md={4}>
    <Form>
        <Form.Group as={Row}>
            <Form.Label column="sm" md={4}>
                NAME
            </Form.Label>
            <Col>
                <Form.Control size="sm" type="text" />
            </Col>
        </Form.Group>
        <Form.Group as={Row}>
            <Form.Label column="sm" md={4}>
                SELECT TASK
            </Form.Label>
            <Col>
                <Form.Control as="select" defaultValue="Choose...">
                    <option>task1</option>
                    <option>task2</option>
                </Form.Control>
            </Col>
        </Form.Group>
        <Form.Group as={Row}>
            <Form.Label column="sm" md={4}>
                DESCRIPTION
            </Form.Label>
            <Col>
                <Form.Control size="sm" plaintext readOnly />
            </Col>
        </Form.Group>
        <Form.Group as={Row}>
            <Form.Label column="sm" md={4}>
                SOLUTION CODE
            </Form.Label>
            <Col>
                <Form.Control size="sm" as="textarea" rows={3}  />
            </Col>
        </Form.Group>
    </Form>
</Col>
