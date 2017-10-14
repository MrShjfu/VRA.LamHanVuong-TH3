function cfmatrix = confusionmatrix()
    imgTrainAll = loadMNISTImages('train-images.idx3-ubyte');
    lblTrainAll = loadMNISTLabels('train-labels.idx1-ubyte');
    Mdl = fitcknn(imgTrainAll', lblTrainAll);
    imgTestAll = loadMNISTImages('t10k-images.idx3-ubyte');
    lblTestAll = loadMNISTLabels('t10k-labels.idx1-ubyte');
    fprintf('dang chay:\n');
    lblPredictTest = predict(Mdl, imgTestAll');
    cfmatrix = confusionmat(lblTestAll, lblPredictTest);
    imshow(cfmatrix, [], 'InitialMagnification', 10000);
end