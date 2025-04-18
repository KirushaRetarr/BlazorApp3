#include "app.hpp"
#include <iostream>

namespace uran {
	void App::run() {
		std::cout << "=====================\n";
		std::cout << "    Project URAN\n";
		std::cout << " Arbitrage Analyzer\n";
		std::cout << "=====================\n";

        int choice;

        do {
            std::cout << "\n=== Main Menu ===\n";
            std::cout << "1. Start scan\n";
            std::cout << "2. Show log\n";
            std::cout << "0. Exit\n";
            std::cout << "Enter your choice: ";
            std::cin >> choice;

            switch (choice) {
            case 1:
                std::cout << "[+] Scanning started...\n";
                break;
            case 2:
                std::cout << "[i] No logs yet.\n";
                break;
            case 0:
                std::cout << "[x] Exiting application.\n";
                break;
            default:
                std::cout << "[!] Invalid choice. Please try again.\n";
            }

        } while (choice != 0);
	}
}
