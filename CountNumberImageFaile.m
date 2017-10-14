function CountNumberImageFaile()
    imgTrainAll = loadMNISTImages('train-images.idx3-ubyte');
    lblTrainAll = loadMNISTLabels('train-labels.idx1-ubyte');
    Mdl = fitcknn(imgTrainAll', lblTrainAll);
    imgTestAll = loadMNISTImages('t10k-images.idx3-ubyte');
    lblTestAll = loadMNISTLabels('t10k-labels.idx1-ubyte');
    fprintf('dang chay:\n');
    
    lblPredictTest = predict(Mdl, imgTestAll');
    for i = 0: 9
        flag = (lblPredictTest == i);
        mark = (lblTestAll == i);
        nCount = (flag==mark & flag ~=0 & mark ~= 0);
        nCount = sum(mark)- sum(nCount);
        fprintf('\nSo luong anh nhan dang sai cua lable %d: %d\n',i,nCount);
    end
end