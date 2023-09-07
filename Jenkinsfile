node {
    def app
   
    stage ('Clean workspace') {
        cleanWs()
    }
    
    stage ('Git Checkout') {
      
      git branch: 'master', credentialsId: 'ba3bdf3e-3541-4f49-a5aa-0644baf85d8c', url: 'https://github.com/oxitbilisim/villaApi.git'
      
    }
    
    stage('Remove Existing Image') {
        sh('docker image rmi villaadmin-be || (echo "Image villaadmin-be didn\'t exist so not removed."; exit 0)')
    }
      
    stage('Build image') {
        /* This builds the actual image; synonymous to
         * docker build on the command line */
        sh('docker build -t villaadmin-be .');
    }
    
    stage('Deploy') {
            sh('docker save villaadmin-be > villaadmin-be.tar')
            sshPublisher(publishers: [sshPublisherDesc(
            configName: 'Villa Prod Server', 
            transfers: 
                [
                    sshTransfer(
                        cleanRemote: false, 
                        excludes: '', 
                        execCommand: '''/root/deploy-commands/deploy-villaadmin-be.sh /tmp''', 
                        execTimeout: 120000, 
                        flatten: false, 
                        makeEmptyDirs: false, 
                        noDefaultExcludes: false, 
                        patternSeparator: '[, ]+', 
                        remoteDirectory: '//tmp//', 
                        remoteDirectorySDF: false, 
                        removePrefix: '', 
                        sourceFiles: 'villaadmin-be.tar'
                    )
                ], 
            usePromotionTimestamp: false, 
            useWorkspaceInPromotion: false, 
            verbose: false)])
        }  
        
        stage('Clear Untagged Images') {
            sh('docker rmi -f $(docker images --filter "dangling=true" -q --no-trunc) || (exit 0)')
        }
        
   
}
