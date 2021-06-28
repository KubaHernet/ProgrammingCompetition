import { Navbar, Nav, Button } from "react-bootstrap";
import "./NavigationBar.scss"

export const NavigationBar = () => 
    <Navbar color="primary" className="navigation-bar justify-content-between px-5 py-3">
        <Navbar.Brand className="navbar-brand"href="/">COGNIZANT CHALLENGE</Navbar.Brand>
        <Nav>
            <Nav.Link href="/"><Button variant="outline-light">Solve</Button></Nav.Link>
            <Nav.Link href="/"><Button variant="outline-light">Top 3</Button></Nav.Link>
        </Nav>
    </Navbar>