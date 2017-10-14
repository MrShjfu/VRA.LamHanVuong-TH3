function statictis=statisticLables(dataLabel)
    allLabels = loadMNISTLabels(dataLabel);
    lstNumber = unique(allLabels);
    statictis = [lstNumber,histc(allLabels(:),lstNumber)];
    bar(statictis)
end 