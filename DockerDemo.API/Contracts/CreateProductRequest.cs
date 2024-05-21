﻿namespace DockerDemo.API.Contracts;

public sealed record CreateProductRequest(
    string Name,
    decimal Price,
    int Quantity);
