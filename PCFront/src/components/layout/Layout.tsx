import React from 'react';
import { Container } from "react-bootstrap";
import { NavigationBar } from './NavigationBar';

export const Layout = ({ children }: {children: React.ReactNode}) => (<>
    <header>
        <NavigationBar />
    </header>
    <main role="main">
        <Container>
            {children}
        </Container>
    </main>
</>);