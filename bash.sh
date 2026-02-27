#!/bin/bash

# Script description
# This script does something useful

set -e  # Exit on error

# Variables
SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"

# Functions
main() {
    echo "Hello from bash script"
    # Add your code here
}

# Run main function
main "$@" 
npm init -y
npm install electron --save-dev  