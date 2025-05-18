# Capstone Mobile Application

This project is a mobile application developed as a **Capstone Project** during my college program. The main goal was to learn and implement technologies I had no prior experience with, within a challenging **10-week timeframe**. This journey involved learning mobile development, integrating third-party libraries, and understanding backend services—all from scratch.

---

## Project Purpose
The purpose of this project was to:
- Understand the structure of a mobile application
- Implement key features like user authentication, data persistence, and API integration
- Explore backend technologies and database management
- Build a user-friendly interface for smooth navigation

---

## Technologies Used
- **Frontend:** Xamarin (Android Focused), integrated with Visual Studio
- **Backend:** Azure Mobile Services, SQLite
- **Data Management:** Newtonsoft.Json for JSON parsing, SQLite for local storage
- **Web Scraping:** IronWebScraper
- **Authentication:** Microsoft Azure Mobile Server Login
- **Networking:** System.IdentityModel.Tokens.Jwt for secure API communication
- **REST API Integration:** Pulling NFL player data from a third-party API

---

## Project Structure
```
CapstoneMobileApplication/
    ├── App/
    │   ├── ViewControllers/
    │   ├── Models/
    │   ├── Views/
    │   └── Resources/
    ├── Backend/
    │   ├── Azure/
    │   ├── Database/
    └── Libraries/
        ├── Newtonsoft.Json/
        ├── IronWebScraper/
        └── SQLite/
```

---

## Installation & Setup
1. Clone the repository:
   ```bash
   git clone https://github.com/YourUsername/CapstoneMobileApplication.git
   ```
2. Navigate to the project directory:
   ```bash
   cd CapstoneMobileApplication
   ```
3. Open the project in **Visual Studio** (Windows or Mac):
   ```bash
   start CapstoneMobileApplication.sln   # Windows
   open CapstoneMobileApplication.sln    # Mac
   ```
4. Build and run the project on your Android simulator or physical device.

---

## Usage
- **Authentication:** Log in using Azure Mobile Services
- **Data Sync:** Pull and push data to cloud services
- **Web Scraping:** Extract data from web sources using IronWebScraper
- **Database Management:** Store and retrieve data with SQLite
- **NFL Player Data:** Fetch player information from a third-party API for display and manipulation

---

## Lessons Learned
This project was a deep learning experience where I:
- Gained hands-on experience with mobile development
- Learned to integrate third-party services
- Understood the basics of backend integration
- Managed data persistence and web scraping
- Integrated and consumed REST APIs in a mobile environment

---

## License
This project is licensed under the MIT License.

