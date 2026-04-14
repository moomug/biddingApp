# BiddingApp(MazadApp)

📖 Project Overview

Arabian Horse MzadApp is a high-performance, scalable auction platform built using a Microservices Architecture. The system enables users to list items for auction and participate in real-time bidding. It is designed with an Event-Driven approach to ensure high availability, fault tolerance, and loose coupling between services.



🏗️ System Architecture

The application is composed of several specialized microservices that interact through both synchronous and asynchronous communication:
- Gateway Service (YARP): Acts as the central entry point, handling request routing and authentication delegation.
- Identity Service (Duende IdentityServer): Manages centralized authentication and authorization for the entire solution.
- Mzad Service: The core domain service managing auction listings and primary business logic (backed by PostgreSQL).
- Filter Service: An optimized read-model service providing advanced search and filtering capabilities (backed by MongoDB).
- Tender Service: Dedicated engine for processing and validating bids (tenders).
- Notification Service: Delivers real-time updates to users via SignalR.


🛠️ Tech Stack

Backend: .NET 8, ASP.NET Core Web API.

Communication:
- Asynchronous: RabbitMQ with MassTransit for reliable event-driven messaging.
- Synchronous: gRPC for low-latency internal service calls.Persistence: PostgreSQL (Relational) and MongoDB (NoSQL).

Frontend:
-  Next.js (App Router), Tailwind CSS, and Zustand for state management.

DevOps & Infrastructure:

- Containerization: Fully Dockerized using Docker Compose.

Orchestration: 

- Kubernetes for managing distributed services.CI/CD: Automated pipelines via GitHub Actions.


🌟 Key Engineering Features

- Event-Driven Consistency: Implements the Outbox Pattern to ensure data consistency across - services even during network partitions.
- Real-time Updates: Sub-second bidding updates and toast notifications powered by WebSockets (SignalR).
- Search Optimization: Real-time data synchronization between PostgreSQL and MongoDB for high-speed filtering.
- Secure SSO: Unified login experience across the platform using OAuth2/OpenID Connect.
- Resiliency: Integrated Polly for handling transient faults in HTTP communication.
