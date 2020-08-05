# Distrolateral-Server

## Description

Being a portmanteau of Distributed and Collateral, Distrolateral Server is a small service designed to run in a distributed containerised environment providing a RESTful API to scripts, binaries and other such material in the local environment. The main aim of the service is to start delivering files to mutiple clients as-soon-as-possible, while minimising the inbound network load- this is essential for environments that data ingress/egress are chargable items.  Features for initial release:

* Client Access:
  * Allow for clients to access files via RESTful API
  * Multiple clients have instant access to files
* File Cacheing (optional):
  * [Amazon S3](https://aws.amazon.com/s3/) storage for cacheing
  * [MinIO](https://min.io/) storage for cacheing
  * Automatic cache grooming
* Scalability:
  * Horizontally scaling the container (probably 2 nodes to start with)
  * Pull from an upstream Distrolateral Server
* Security:
  * TBD: I am thinking certificate based auth for communication with upstreams.
