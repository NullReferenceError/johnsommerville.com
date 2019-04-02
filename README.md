# johnsommerville.com

This is my personal resume site. 
Commits to this site automatically build in Azure DevOps, and Pull Requests to master are automatically deployed.
Currently this site is running in a docker container, deployed to the Azure Kubernetes Service with help from Helm.

[![Build Status](https://dev.azure.com/jacksomm/jacksomm/_apis/build/status/johnsommerville-com?branchName=master)](https://dev.azure.com/jacksomm/jacksomm/_build/latest?definitionId=2&branchName=master)

Check list of things to do still:
* Use Helm to get Let's Encrypt automated SSL cert process working
* Publish Docker Image to an Amazon ECR
* Deploy to Kubernetes instance on AWS
* Publish Docker Image to a Google Cloud Container Registry
* Deploy to Google Kubernetes instance
* Setup NGinx reverse proxy pointing to other cloud service deployments
* Move pagedata into database
* Start blog pages
* Start testing ground/project pages
