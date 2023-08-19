# My Ride- Ride Hailing Application

My Ride is a console-based ride hailing application that offers various functionalities to users, drivers, and administrators. The application allows users to book rides, drivers to manage their availability and location, and administrators to manage driver information. This readme provides an overview of the application, its features, usage instructions, contributors, license, and acknowledgments.

## Features

### Book a Ride

The application enables users to book rides by providing their information, start and end locations, and selecting a ride type. The process involves:

1. Entering user details: name, phone number.
2. Specifying the start and end locations as (x, y) coordinates.
3. Choosing a ride type.
4. Calculating the ride price (fixed at 200 for demonstration purposes).
5. Confirming the booking and providing a rating (if booked).

### Driver Functions

Drivers can access the following functions:

- Change availability status.
- Update current location.

### Admin Functions

Administrators can perform various actions:

- Add a driver to the system.
- Update driver information.
- Delete a driver.
- Search for drivers based on parameters.

## Getting Started

1. Clone the repository to your local machine.
2. Compile the application using Visual Studio.
3. Run the compiled executable.

## Usage

Upon running the application, you'll be presented with a menu:

- Press `1` to book a ride.
- Press `2` to enter as a driver (not implemented).
- Press `3` to enter as an admin (not implemented).

For booking a ride, follow these steps:

1. Enter your name and phone number.
2. Input the start and end locations in (x, y) format.
3. Select a ride type.
4. Confirm the booking with 'Y' or cancel with 'N'.
5. If confirmed, provide a rating out of 5.

For driver functions, enter `2` and follow the prompts to update availability and location.

For admin functions, enter `3` and choose from options to add, update, delete, or search for drivers.
