<h1 align="center">Random Text Generation and Kafka Sending</h1>

This is a sample project in .NET Core that generates random texts and sends them to a Kafka topic using the Confluent.Kafka library.

## 🚀 Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) installed
- [Docker Desktop](https://www.docker.com/products/docker-desktop) (optional, if you are using Kafka in a Docker container)
- Basic knowledge of Kafka and programming in C#

## 🔧 Installation

1. **Clone this repository:**

```bash
git clone https://github.com/guilhermebernava/LogGeneratorWithKafka.git
```

2. **Navigate to the project directory:**

```bash
cd your-project
```

3. **Restore project dependencies:**

```bash
dotnet restore
```

4. **(Optional) Start Kafka cluster using Docker (if you don't have a Kafka cluster running):**

```bash
docker run -p 9092:9092 apache/kafka:3.7.0
```

## ⚙️ Configuration

Before running the project, you need to configure the Kafka server address and the Kafka topic name where the data will be sent.

1. Open the `appsettings.json` file in the project directory.

2. Edit the following settings as needed:

```json
{
  "Kafka": "localhost:9092", // Replace with your Kafka server address
  "TopicName": "your-topic" // Replace with your Kafka topic name
}
```

## 🚀 Usage

1. **Run the project:**

```bash
dotnet run
```
